const API_BASE_URL = "https://localhost:7062/api";

// Get Classes
export async function getClasses() {
    const response = await fetch(`${API_BASE_URL}/Classes`);
    if (!response.ok) {
        throw new Error("Failed to fetch classes");
    }
    return response.json();
}

// Get Skills
export async function getSkills() {
    const response = await fetch(`${API_BASE_URL}/Skills`);
    if (!response.ok) {
        throw new Error("Failed to fetch skills");
    }
    return response.json();
}

// Get Skill Upgrades
export async function getSkillUpgrades() {
    const response = await fetch(`${API_BASE_URL}/SkillUpgrade`);
    if (!response.ok) throw new Error("Failed to fetch skill upgrades");
    return response.json();
}
