function jsonStringify(obj) {
    let type = typeof obj;

    if (type !== "object" || type === null) {
        if (/string|undefined|function/.test(obj)) {
            obj = '"' + obj + '"';
        }
        return String(obj);
    }