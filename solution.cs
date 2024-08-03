Here is a simple implementation of a basic JSON.stringify function in JavaScript:

```javascript
function jsonStringify(obj) {
    let type = typeof obj;

    if (type !== "object" || type === null) {
        if (/string|undefined|function/.test(obj)) {
            obj = '"' + obj + '"';
        }
        return String(obj);
    } else {
        let json = []
        , arr = (obj && obj.constructor === Array);
        for (let k in obj) {
            let v = obj[k];
            type = typeof v;
            if (/string|undefined|function/.test(type)) {
                v = '"' + v + '"';
            } else if (type === "object" && type !== null){
                v = jsonStringify(v);
            }
            json.push((arr ? "" : '"' + k + '":') + String(v));
        }
        return (arr ? "[" : "{") + String(json) + (arr ? "]" : "}");
    }
}

console.log(jsonStringify({x : 5, y : 6}));
console.log(jsonStringify([1, 2, 3]));
```

This code will output:

```bash
{"x":5,"y":6}
[1,2,3]
```

This is a very basic implementation and does not handle all the edge cases that the real JSON.stringify function does.