else {
        let json = []
        , arr = (obj && obj.constructor === Array);
        for (let k in obj) {
            let v = obj[k];
            type = typeof v;