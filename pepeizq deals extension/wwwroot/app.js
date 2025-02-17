export function beforeStart(options, extensions, blazorBrowserExtension) {
    if (blazorBrowserExtension.BrowserExtension.Mode === blazorBrowserExtension.Modes.ContentScript) {     

        if (window.location.href.indexOf("store.steampowered.com/app/") > -1 || window.location.href.indexOf("store.steampowered.com/dlc/") > -1) {
            const appDiv = document.createElement("div");
            appDiv.id = "pepeizqdeals";

            if (document.getElementById("game_area_purchase")) {
                document.getElementById("game_area_purchase").insertBefore(appDiv, document.getElementById("game_area_purchase").firstChild);
            }
        }

        if (window.location.href.indexOf("gog.com/en/game/") > -1 || window.location.href.indexOf("gog.com/de/game/") > -1 || window.location.href.indexOf("gog.com/fr/game/") > -1) {
            const appDiv = document.createElement("div");
            appDiv.id = "pepeizqdeals";

            if (document.getElementsByClassName("product-actions-body")[0]) {
                var firstMatch = document.getElementsByClassName("product-actions-body")[0];
                firstMatch.appendChild(appDiv);
            }
        }
    }
}