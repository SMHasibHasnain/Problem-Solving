const LOCAL = false;

let input;
if (LOCAL) {
    input = `ViP`.trim().split('\n');
} else {
    input = require('fs').readFileSync(0, 'utf-8').trim().split('\n');
}

let currentLine = 0;
const readLine = () => input[currentLine++].trim();

function main() {
  let arr = readLine().split("");

  let toUpperCaseCount = 0;

  for(let i=0; i<arr.length; i++) {
    if(arr[i] == arr[i].toUpperCase()) toUpperCaseCount++; 
  }

  let toLowerCaseCount = arr.length - toUpperCaseCount;


  if(toUpperCaseCount > toLowerCaseCount) {
    console.log(arr.map(element => element.toUpperCase()).join(""));
  } else {
    console.log(arr.map(element => element.toLowerCase()).join(""));
  }


}

main();