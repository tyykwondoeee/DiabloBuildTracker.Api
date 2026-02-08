import { rm } from 'node:fs/promises';
import { execSync } from 'node:child_process';

const isWindows = process.platform === 'win32';

function tryKillNodeOnWindows() {
  if (!isWindows) return;

  try {
    execSync('taskkill /F /IM node.exe', { stdio: 'ignore' });
    console.log('Stopped running node.exe processes to release file locks.');
  } catch {
    console.log('No running node.exe processes found (or none could be stopped).');
  }
}

async function removePath(path) {
  await rm(path, {
    recursive: true,
    force: true,
    maxRetries: 5,
    retryDelay: 200
  });
  console.log(`Removed ${path}`);
}

async function main() {
  tryKillNodeOnWindows();

  await removePath('node_modules');
  await removePath('package-lock.json');

  console.log('\nReset complete. Run: npm install && npm run dev');
} 

main().catch((error) => {
  console.error('Reset failed.');
  console.error(error.message);
  process.exit(1);
});
