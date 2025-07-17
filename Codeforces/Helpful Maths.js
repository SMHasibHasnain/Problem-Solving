const LOCAL = false;

let input;
if (LOCAL) {
    input = `3+2+1`.trim().split('\n');
} else {
    input = require('fs').readFileSync(0, 'utf-8').trim().split('\n');
}

let currentLine = 0;
const readLine = () => input[currentLine++].trim();

function main() {
  let s = readLine().split("+");
  
  s.sort((a, b) => a-b);

  console.log(s.join("+"));


}

main();