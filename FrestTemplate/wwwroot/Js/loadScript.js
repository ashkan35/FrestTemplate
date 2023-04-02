// loadScript: returns a promise that completes when the script loads
window.loadScript = function (scriptPath) {
    // check list - if already loaded we can ignore
    if (loaded[scriptPath]) {
        console.log(scriptPath + " already loaded");
        // return 'empty' promise
        return new this.Promise(function (resolve, reject) {
            resolve();
        });
    }

    return new Promise(function (resolve, reject) {
        // create JS library script element
        var script = document.createElement("script");
        script.src = scriptPath;
        script.type = "text/javascript";
        console.log(scriptPath + " created");

        // flag as loading/loaded
        loaded[scriptPath] = true;

        // if the script returns okay, return resolve
        script.onload = function () {
            console.log(scriptPath + " loaded ok");
            resolve(scriptPath);
        };

        // if it fails, return reject
        script.onerror = function () {
            console.log(scriptPath + " load failed");
            reject(scriptPath);
        }

        // scripts will load at end of body
        document["body"].appendChild(script);
    });
}
// store list of what scripts we've loaded
var loaded = [];
window.loadLink = function (cssPath) {
    // check list - if already loaded we can ignore
    if (loadedCss[cssPath]) {
        console.log(cssPath + " already loaded");
        // return 'empty' promise
        return new this.Promise(function (resolve, reject) {
            resolve();
        });
    }

    return new Promise(function (resolve, reject) {
        // create css link element
        var link = document.createElement("link");
        link.rel = "stylesheet";
        link.href = cssPath ;
        console.log(cssPath + " created");

        // flag as loading/loaded
        loadedCss[cssPath] = true;

        // if the script returns okay, return resolve
        link.onload = function () {
            console.log(cssPath + " loaded ok");
            resolve(cssPath);
        };

        // if it fails, return reject
        link.onerror = function () {
            console.log(cssPath + " load failed");
            reject(cssPath);
        }

        // scripts will load at end of body
        document["head"].appendChild(link);
    });
}
var loadedCss = [];