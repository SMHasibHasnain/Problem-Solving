// CONFIGURATION SWITCH
const LOCAL = false;

// Input Handler: Local (VSCode) or Online Judge (Codeforces)
let input;
if (LOCAL) {
    // VSCode: Paste problem input here
    input = `4
    7`.trim().split('\n');
} else {
    // Codeforces: Read from standard input (stdin)
    input = require('fs').readFileSync(0, 'utf-8').trim().split('\n');
}

// Line reader
let currentLine = 0;
const readLine = () => input[currentLine++].trim();

// Main Logic Function
function main() {
  //readLine for input


    
}

main();