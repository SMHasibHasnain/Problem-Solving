const LOCAL = false;

let input;
if (LOCAL) {
    input = `7
DDDAADA`.trim().split('\n');
} else {
    input = require('fs').readFileSync('/dev/stdin', 'utf-8').trim().split('\n');
}

let currentLine = 0;
const readLine = () => input[currentLine++];

function main() {
  let n = Number(readLine());
  let s = readLine();

  let anton = 0;
  let danik = 0;

  for(let i=0; i<s.length; i++) {
    if(s.charAt(i) === "A") {
      anton++; 
    } else {
      danik++; 
    }  
  }

  if(anton > danik) {
    console.log("Anton");
  } else if(danik > anton) {
    console.log("Danik");
  } else {
    console.log("Friendship");
  }
}

main()