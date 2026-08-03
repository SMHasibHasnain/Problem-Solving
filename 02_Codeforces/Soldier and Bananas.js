const LOCAL = false;

let input;
if (LOCAL) {
    input = `3 17 4`.trim().split('\n');
} else {
    input = require('fs').readFileSync(0, 'utf-8').trim().split('\n');
}

let currentLine = 0;
const readLine = () => input[currentLine++].trim();

function main() {
  let [k, n, w] = readLine().split(" ");

  k = Number(k);
  n = Number(n);
  w = Number(w);


  let m = 0;

  for(let i=1; i<w+1; i++) {
    m = (k * i) + m;
  }

  let calc = m - n;

  if(calc<0) {
    console.log("0");
  } else {
    console.log(calc);
  }

}

main();