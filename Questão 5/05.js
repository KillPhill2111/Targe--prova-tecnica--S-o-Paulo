let frase01='O rato roeu a ropupa'
let frase02='JavaScript continua sendo melhor que python??'
let frase03='Batatti quando nasce...'
let frase04='Exemplo de string 01'
let frase05='Exemplo de string 02'


function inverterString(senteca){
    let finalSentenca=''

    for(let i=senteca.length-1; i>=0; i--){
        finalSentenca+=senteca[i]
    }
    return finalSentenca
}

console.log(inverterString(frase01))
console.log(inverterString(frase02))
console.log(inverterString(frase03))
console.log(inverterString(frase04))
console.log(inverterString(frase05))
