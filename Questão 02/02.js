let numero=7;

console.log(fibonacci(numero))

function fibonacci(n){
    if(n<=1){
        return n
    }
    else{
        n=fibonacci(n-2)+fibonacci(n-1)
        return n
    }
    
}
/**
 * 0---------- 1º
 * 0+1=1------ 2º
 * 1+1=2       3º
 * 1+2=3       4º
 * 3+2=5       5º
 * 5+3=8       6º
 * 8+5=13      7º
 * 
 * 
 * 
 */