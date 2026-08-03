// CONFIGURATION SWITCH
const LOCAL = true;

// Input Handler: Local (VSCode) or Online Judge (Codeforces)
let input;
if (LOCAL) {
    // VSCode: Paste problem input here
    input = `4 7`.trim().split('\n');
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

  let userInput = readLine().split(" ");

  let a = Number(userInput[0]);
  let b = Number(userInput[1]);

  let years = 0;

  while (a<=b) {
    a *= 3;
    b *= 2;
    years++;

  }

  console.log(years);
    
}

main();