const LOCAL = false;

let input;
if (LOCAL) {
    input = `Codeforces`.trim().split('\n');
} else {
    input = require('fs').readFileSync(0, 'utf-8').trim().split('\n');
}

let currentLine = 0;
const readLine = () => input[currentLine++].trim();

function main() {
  let vowel = ["a", "e", "i", "o", "u", "y"];
  
  let word = readLine().split("");
  let word2 = [];
  let n = word.length;

  for(let i=0; i<n; i++) {
    if(!(vowel.includes(word[i].toLowerCase()))) {
      word2.push(".", word[i].toLowerCase());
    }
  }

  let str = word2.join("");
  console.log(str);

}

main();