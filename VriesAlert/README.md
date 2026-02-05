# VriesAlert - PWA

Een Blazor WebAssembly Progressive Web App die waarschuwt wanneer de buitentemperatuur onder 0°C komt.

## Features

- 📱 **PWA:** Installeerbaar op mobiel (iOS/Android) en desktop.
- 🌍 **Locatie-gebaseerd:** Gebruikt GPS om lokale weerdata op te halen.
- ☀️ **API:** Koppeling met Open-Meteo voor realtime weerinformatie.
- 🔔 **Notificaties:** Stuurt een melding bij vorst (indien toestemming gegeven).
- 🎨 **Dynamisch Design:** De achtergrond verandert mee met de temperatuur (Blauw bij vorst, Groen bij veilig).

## Hoe te starten

1.  Zorg dat .NET 10.0 (of nieuwer) geïnstalleerd is.
2.  Navigeer naar de projectmap.
3.  Run het project:
    ```bash
    dotnet run
    ```
4.  Open de browser op de getoonde URL (meestal `http://localhost:5xxx` of `https://localhost:7xxx`).

## Installatie op Mobiel

- **iOS:** Open in Safari -> Deel knop -> "Zet op beginscherm".
- **Android:** Open in Chrome -> Menu -> "App installeren".

## Technische Stack

- .NET 10 Blazor WebAssembly
- Open-Meteo API
- HTML5 Geolocation & Notifications API
