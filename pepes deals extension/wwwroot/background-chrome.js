chrome.runtime.onMessage.addListener((msg, sender, sendResponse) => {

    if (msg.action === "ObtenerHtml") {
        fetch(msg.enlace, { cache: "no-store" })
            .then(res => res.json())
            .then(data => sendResponse(data));

        return true; 
    }
});