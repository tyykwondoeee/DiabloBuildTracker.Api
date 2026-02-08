import { useEffect, useState } from 'react';
import ClassCard from '../components/ClassCard';
import { getClasses } from '../api';

const imageMap = {
  barbarian: 'https://images.blz-contentstack.com/v3/assets/blt5bbf09732528de36/bltef013ea2981b5789/64f7d84dec302f9703dc6f22/barbarian-select.jpg',
  druid: 'https://images.blz-contentstack.com/v3/assets/blt5bbf09732528de36/bltf5a22dcbfc0ebabb/64f7d84dec302f9703dc6f3a/druid-select.jpg',
  necromancer: 'https://images.blz-contentstack.com/v3/assets/blt5bbf09732528de36/bltb5ecf5f5fce32af7/64f7d84dec302f9703dc6f26/necromancer-select.jpg',
  rogue: 'https://images.blz-contentstack.com/v3/assets/blt5bbf09732528de36/blte7b0601d1a90e220/64f7d84dec302f9703dc6f31/rogue-select.jpg',
  sorcerer: 'https://images.blz-contentstack.com/v3/assets/blt5bbf09732528de36/bltd22b3b28de0b9230/64f7d84dec302f9703dc6f35/sorcerer-select.jpg',
  spiritborn: 'https://images.blz-contentstack.com/v3/assets/blt5bbf09732528de36/blt62d4ce98095a31dd/6674b9d76056d75f5375deff/spiritborn-keyart-mobile.jpg',
  paladin: 'https://images.blz-contentstack.com/v3/assets/blt5bbf09732528de36/blt5b4a04f04f94bb0a/64f7d84dec302f9703dc6f20/cathedral-guardian.jpg'
};

function getImageUrl(name) {
  const key = name.toLowerCase();
  if (key === 'sprirtborn') {
    return imageMap.spiritborn;
  }

  return imageMap[key] ?? imageMap.paladin;
}

export default function ClassSelectionPage() {
  const [classes, setClasses] = useState([]);
  const [error, setError] = useState('');

  useEffect(() => {
    getClasses().then(setClasses).catch(() => {
      setError('Could not load classes from the API. Make sure the backend is running.');
    });
  }, []);

  return (
    <main className="page-shell">
      <header>
        <h1>Diablo Build Tracker</h1>
        <p>Select a class to start choosing your skills.</p>
      </header>

      {error ? <p className="error">{error}</p> : null}

      <section className="class-grid">
        {classes.map((diabloClass) => (
          <ClassCard
            key={diabloClass.id}
            diabloClass={diabloClass}
            imageUrl={getImageUrl(diabloClass.name)}
          />
        ))}
      </section>
    </main>
  );
}
