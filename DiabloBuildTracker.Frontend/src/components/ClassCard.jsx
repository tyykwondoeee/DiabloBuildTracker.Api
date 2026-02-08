import { Link } from 'react-router-dom';

export default function ClassCard({ diabloClass, imageUrl }) {
  return (
    <Link className="class-card" to={`/class/${diabloClass.id}`}>
      <img src={imageUrl} alt={`${diabloClass.name} artwork`} className="class-image" />
      <span className="class-name">{diabloClass.name}</span>
    </Link>
  );
}
