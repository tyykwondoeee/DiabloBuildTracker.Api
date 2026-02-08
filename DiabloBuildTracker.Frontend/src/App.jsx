import { Navigate, Route, Routes } from 'react-router-dom';
import ClassSelectionPage from './pages/ClassSelectionPage';
import SkillSelectionPage from './pages/SkillSelectionPage';

export default function App() {
  return (
    <Routes>
      <Route path="/" element={<ClassSelectionPage />} />
      <Route path="/class/:classId" element={<SkillSelectionPage />} />
      <Route path="*" element={<Navigate to="/" replace />} />
    </Routes>
  );
}
