const LOCAL = true;

let input;
if (LOCAL) {
    input = `1000000000 9`.trim().split('\n');
} else {
    input = require('fs').readFileSync(0, 'utf-8').trim().split('\n');
}

let currentLine = 0;
const readLine = () => input[currentLine++].trim();

function main() {
  
let [n, k] = readLine().split(" ");

n = Number(n);
k = Number(k);

while(k>0) {
  if(n%10 == 0) {
    n = n/10;
  } else {
    n--;
  }
  k--;
}

console.log(n);

}

main();