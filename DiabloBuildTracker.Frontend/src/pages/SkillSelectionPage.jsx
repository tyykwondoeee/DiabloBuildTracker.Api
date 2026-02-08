import { useEffect, useMemo, useState } from 'react';
import { Link, useParams } from 'react-router-dom';
import { getClasses, getSkills } from '../api';

export default function SkillSelectionPage() {
  const { classId } = useParams();
  const [classes, setClasses] = useState([]);
  const [skills, setSkills] = useState([]);
  const [selectedSkills, setSelectedSkills] = useState({});
  const [error, setError] = useState('');

  useEffect(() => {
    Promise.all([getClasses(), getSkills()])
      .then(([classData, skillData]) => {
        setClasses(classData);
        setSkills(skillData);
      })
      .catch(() => {
        setError('Could not load class skills. Make sure the backend is running.');
      });
  }, []);

  const selectedClass = useMemo(
    () => classes.find((item) => item.id === Number(classId)),
    [classes, classId]
  );

  const classSkills = useMemo(
    () => skills.filter((skill) => skill.classId === Number(classId)),
    [skills, classId]
  );

  function toggleSkill(skillId) {
    setSelectedSkills((current) => ({
      ...current,
      [skillId]: !current[skillId]
    }));
  }

  return (
    <main className="page-shell">
      <Link className="back-link" to="/">
        ← Back to classes
      </Link>

      <header>
        <h1>{selectedClass ? `${selectedClass.name} Skills` : 'Class Skills'}</h1>
        <p>Pick the skills you want for this build.</p>
      </header>

      {error ? <p className="error">{error}</p> : null}

      <section className="skills-list">
        {classSkills.map((skill) => (
          <label key={skill.id} className="skill-item">
            <input
              type="checkbox"
              checked={Boolean(selectedSkills[skill.id])}
              onChange={() => toggleSkill(skill.id)}
            />
            <span>{skill.name}</span>
          </label>
        ))}
      </section>
    </main>
  );
}
