export function beforeStart(options, extensions, blazorBrowserExtension) {
    if (blazorBrowserExtension.BrowserExtension.Mode === blazorBrowserExtension.Modes.ContentScript)
    {     
        if (window.location.href.indexOf("store.steampowered.com/app/") > -1 || window.location.href.indexOf("store.steampowered.com/dlc/") > -1) {
            const appDiv = document.createElement("div");
            appDiv.id = "pepeizqdeals";

            if (document.getElementById("game_area_purchase")) {
                document.getElementById("game_area_purchase").insertBefore(appDiv, document.getElementById("game_area_purchase").firstChild);
            }
        }

        if (window.location.href.indexOf("gog.com/") > -1 && window.location.href.indexOf("/game/") > -1) {
            const appDiv = document.createElement("div");
            appDiv.id = "pepeizqdeals";

            if (document.getElementsByClassName("product-actions-body")[0]) {
                var firstMatch = document.getElementsByClassName("product-actions-body")[0];
                firstMatch.appendChild(appDiv);
            }
        }

        if (window.location.href.indexOf("store.epicgames.com/") > -1 && window.location.href.indexOf("/p/") > -1) {
            const appDiv = document.createElement("div");
            appDiv.id = "pepeizqdeals";

            if (document.getElementsByClassName("css-1vedkaf")[0]) {
                var firstMatch = document.getElementsByClassName("css-1vedkaf")[0];
                firstMatch.appendChild(appDiv);
            }
        }
    }
}