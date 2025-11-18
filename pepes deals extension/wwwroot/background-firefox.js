browser.runtime.onMessage.addListener(async (msg) => {
    if (msg.action === "ObtenerHtml") {
        const res = await fetch(msg.enlace);
        const data = await res.json();
        return data;
    }
});