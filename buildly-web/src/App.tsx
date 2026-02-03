import React, { useEffect, useState } from "react";
import { getClasses, getSkills } from "./services/api";

type ClassType = {
    id: number;
    name: string;
};

type SkillType = {
    id: number;
    name: string;
    classId: number;
    skillCategoryId: number;
};

type Character = {
    class: ClassType;
    skills: string[];
};

// Skill Categories
const skillCategoryNames: Record<number, string> = {
    1: "Basic",
    2: "Core",
    3: "Defensive",
    4: "Passive",
    5: "Brawling",
    6: "Weapon Mastery",
    7: "Upgrades",
    8: "Ultimate",
    9: "Key Passive",
    10: "Companion",
    11: "Wrath",
    12: "Curse",
    13: "Corpse & Macabre",
    14: "Agility",
    15: "Subterfuge",
    16: "Imbuement",
    17: "Conjuration",
    18: "Mastery",
    19: "Focus",
    20: "Potency"
};

// Class Skills
const classSkillOrder: Record<number, number[]> = {
    1: [1, 2, 3, 5, 6, 7],   // Barbarian
    2: [1, 2, 3, 10, 11, 7],      // Druid
    3: [1, 2, 13, 12, 13, 7],     // Necromancer
    4: [1, 2, 14, 15, 16, 7],  // Rogue
    5: [1, 2, 3, 17, 18, 7],      // Sorcerer
    6: [1, 2, 19, 3, 20, 7],      // Spiritborn
    7: [1, 6, 2, 3, 4]    // Paladin
};

function App() {
    const [classes, setClasses] = useState<ClassType[]>([]);
    const [skills, setSkills] = useState<SkillType[]>([]);
    const [selectedClass, setSelectedClass] = useState<ClassType | null>(null);
    const [availableSkills, setAvailableSkills] = useState<SkillType[]>([]);
    const [allowedCategoryIndex, setAllowedCategoryIndex] = useState<number>(0);
    const [character, setCharacter] = useState<Character | null>(null);
    const [loading, setLoading] = useState(true);

    // Get Classes/Skills
    useEffect(() => {
        async function fetchData() {
            try {
                const [classesData, skillsData] = await Promise.all([getClasses(), getSkills()]);
                setClasses(classesData);
                setSkills(skillsData);
                setLoading(false);
            } catch (err) {
                console.error("Failed to fetch classes or skills:", err);
                setLoading(false);
            }
        }
        fetchData();
    }, []);

    // Class Selection
    const handleClassSelect = (c: ClassType) => {
        setSelectedClass(c);
        setCharacter({
            class: c,
            skills: []
        });

        setAllowedCategoryIndex(0);

        // Filter skills
        const classSkills = skills.filter(skill => skill.classId === c.id);
        setAvailableSkills(classSkills);
    };

    // Determine Current Category
    const currentCategoryId = selectedClass
        ? classSkillOrder[selectedClass.id]?.[allowedCategoryIndex] || 1
        : 1;

    // Handle Skill Selection
    const handleSkillSelect = (skill: SkillType) => {
        if (!character) return;

        // Only allow current category
        if (skill.skillCategoryId !== currentCategoryId) return;

        if (!character.skills.includes(skill.name)) {
            const updatedSkills = [...character.skills, skill.name];
            setCharacter({ ...character, skills: updatedSkills });

            const remaining = availableSkills.filter(
                s => s.skillCategoryId === currentCategoryId && !updatedSkills.includes(s.name)
            );

            // Unlock next category
            if (remaining.length === 0) {
                setAllowedCategoryIndex(prev => prev + 1);
            }
        }
    };

    if (loading) {
        return <div>Loading classes...</div>;
    }

    // UI
    return (
        <div style={{ padding: "2rem" }}>
            <h1>Buildly</h1>
            <h2>Choose Your Class</h2>

            {/* Class List */}
            <ul>
                {classes.map(c => (
                    <li
                        key={c.id}
                        onClick={() => handleClassSelect(c)}
                        style={{
                            cursor: "pointer",
                            fontWeight: selectedClass?.id === c.id ? "bold" : "normal",
                            backgroundColor: selectedClass?.id === c.id ? "#ddd" : "transparent",
                            padding: "0.5rem",
                            borderRadius: "5px",
                            marginBottom: "0.2rem"
                        }}
                    >
                        {c.name}
                    </li>
                ))}
            </ul>

            {/* Character Building Section */}
            {character && (
                <div style={{ marginTop: "2rem" }}>
                    {/* Display selected class */}
                    <h3>Selected Class: {character.class.name}</h3>

                    {/* Skill Selection */}
                    <h4>Choose {skillCategoryNames[currentCategoryId]}</h4>
                    <div style={{ display: "flex", gap: "1rem", flexWrap: "wrap" }}>
                        {availableSkills
                            .filter(skill => skill.skillCategoryId === currentCategoryId)
                            .map(skill => (
                                <button
                                    key={skill.id}
                                    onClick={() => handleSkillSelect(skill)}
                                    style={{
                                        padding: "0.5rem 1rem",
                                        backgroundColor: character.skills.includes(skill.name)
                                            ? "#4caf50"
                                            : "#eee",
                                        color: character.skills.includes(skill.name) ? "#fff" : "#000",
                                        border: "none",
                                        borderRadius: "5px",
                                        cursor: "pointer"
                                    }}
                                >
                                    {skill.name}
                                </button>
                            ))}
                    </div>

                    {/* Display skills */}
                    {character.skills.length > 0 && (
                        <div style={{ marginTop: "1rem" }}>
                            <strong>Selected Skills:</strong> {character.skills.join(", ")}
                        </div>
                    )}
                </div>
            )}
        </div>
    );
}

export default App;
