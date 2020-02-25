# Axceligent-Test

Question #5 Method Signature 

async Task<KeyValuePair<double, int>> SomeCalculation(long, int, bool);


Question #7 ES6 Import

answers true for type 1 {{ import {Car} from "app.js"; }} are :
answer 1

//app.js
export function Car(){
    return "lamborghini";
}

answers true for type 2 {{ import Car from "app.js"; }} are :
answer 2

//app.js
export default function Car(){
    return "lamborghini";
}

answer 4

//app.js
function Car(){
    return "lamborghini";
}
export default Car;



