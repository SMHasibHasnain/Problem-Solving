const LOCAL = false;

let input;
if (LOCAL) {
    input = `12`.trim().split('\n');
} else {
    input = require('fs').readFileSync(0, 'utf-8').trim().split('\n');
}

let currentLine = 0;
const readLine = () => input[currentLine++].trim();

function main() {

  let x = Number(readLine());
  
  const optns = [1, 2, 3, 4, 5];

  let mv = 0;

  let pos = optns.length - 1;

  let steps = 0;

  while(x !== mv && pos >= 0) {
    if((optns[pos] + mv) <= x) {
      mv += optns[pos];
      steps++;
    } else {
      pos--;
    }
  }
  console.log(steps);
}



main();