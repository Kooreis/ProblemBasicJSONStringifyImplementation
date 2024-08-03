Here is a simple implementation of a JSON.stringify function in TypeScript:

```typescript
class JsonStringify {
    stringify(value: any): string {
        switch (typeof value) {
            case 'string':
                return `"${value}"`;
            case 'boolean':
            case 'number':
                return value.toString();
            case 'object':
                if (Array.isArray(value)) {
                    return '[' + value.map(item => this.stringify(item)).join(',') + ']';
                } else {
                    let objString = '{';
                    for (let key in value) {
                        if (value.hasOwnProperty(key)) {
                            objString += `"${key}":${this.stringify(value[key])},`;
                        }
                    }
                    return objString.slice(0, -1) + '}';
                }
            default:
                return 'null';
        }
    }
}

let jsonStringify = new JsonStringify();
console.log(jsonStringify.stringify({ name: "John", age: 30, city: "New York" }));
```

This code creates a class `JsonStringify` with a method `stringify` that takes a value and returns a string representation of that value in JSON format. The `stringify` method uses a switch statement to handle different types of values: strings, booleans, numbers, and objects. For objects, it checks if the object is an array and handles it accordingly. If the object is not an array, it iterates over the object's properties and adds them to the string representation. If the value is not a string, boolean, number, or object, it returns 'null'. The `console.log` statement at the end tests the `stringify` method with a sample object.