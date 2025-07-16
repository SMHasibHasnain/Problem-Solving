const LOCAL = false;

let input;
if (LOCAL) {
    input = `4
    BRBG`.trim().split('\n');
} else {
    input = require('fs').readFileSync(0, 'utf-8').trim().split('\n');
}

let currentLine = 0;
const readLine = () => input[currentLine++].trim();

function main() {
  
  let n = Number(readLine());
  let str = String(readLine());
  let arr = str.split("");

  let i = 0;
  let store;
  let s = 0;  

  while(i < n) {

    if (store === arr[i]) s++;

    store = arr[i];

    i++;

  }

  console.log(s);
    
}

main();