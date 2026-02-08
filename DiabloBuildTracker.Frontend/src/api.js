const API_BASE_URL = import.meta.env.VITE_API_BASE_URL ?? 'https://localhost:7168';

async function getJson(path) {
  const response = await fetch(`${API_BASE_URL}${path}`);
  if (!response.ok) {
    throw new Error(`Request failed: ${response.status}`);
  }

  return response.json();
}

export function getClasses() {
  return getJson('/api/class');
}

export function getSkills() {
  return getJson('/api/skills');
}
