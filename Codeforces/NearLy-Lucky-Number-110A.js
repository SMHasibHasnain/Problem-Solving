const LOCAL = false;

let input;
if (LOCAL) {
    input = `47747474`.trim().split('\n');
} else {
    input = require('fs').readFileSync(0, 'utf-8').trim().split('\n');
}

let currentLine = 0;
const readLine = () => input[currentLine++].trim();

function main() {
  let n = readLine();
  let count = 0;
  for (let i = 0; i < n.length; i++) {
    if (n[i] === "4" || n[i] === "7") count++;
  }
  if (count === 4 || count === 7) {
    console.log("YES");
  } else {
    console.log("NO");
  }
}

main();