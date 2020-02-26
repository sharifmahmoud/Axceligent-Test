# Axceligent-Test

# Question #5 Method Signature 

async Task<KeyValuePair<double, int>> SomeCalculation(long, int, bool);

-----------------------------------------------------------------------------
# Question #7 ES6 Import

answers true for type 1 {{ import {Car} from "app.js"; }} are :

**answer 1

//app.js

export function Car(){
    return "lamborghini";
}

------------------------------------------------------------------
answers true for type 2 {{ import Car from "app.js"; }} are :

**answer 2

//app.js

export default function Car(){
    return "lamborghini";
}

**answer 4

//app.js
function Car(){
    return "lamborghini";
}
export default Car;

----------------------------------------------------
# Question 8 
 ``` typescript
 function operatorFactory(operator: (result: number) => number) {
  return (
    target: Object,
    propertyName: string,
    propertyDescriptor: PropertyDescriptor,
  ) => {
    const method = propertyDescriptor.value;

    propertyDescriptor.value = function (...args: any[]) {

      const result = method.apply(this, args); // Call original function

      return operator(result); // Call operator
    }

    return propertyDescriptor;
  } 
}

 function subtract(subtrahend: number = 1) {
  return operatorFactory((num: number) => {
    return num - subtrahend;
  });
};

 function multiply(factors: number = 1) {
  return operatorFactory((num: number) => {
    return num * factors;
  });
}

class MathClass{

  
    @subtract(1)
    @multiply(2)
    addOne(number:number) {
       return number+1;
   }
}
 
console.log(new MathClass().addOne(2)) //should print 5
```
