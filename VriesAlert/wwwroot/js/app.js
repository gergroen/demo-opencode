window.vriesAlert = {
    getGeolocation: function () {
        return new Promise((resolve, reject) => {
            if (!navigator.geolocation) {
                reject("Geolocation is not supported by this browser.");
            } else {
                navigator.geolocation.getCurrentPosition(
                    (position) => {
                        resolve({
                            latitude: position.coords.latitude,
                            longitude: position.coords.longitude,
                            accuracy: position.coords.accuracy
                        });
                    },
                    (error) => {
                        let errorMsg = "Unknown error";
                        switch(error.code) {
                            case error.PERMISSION_DENIED: errorMsg = "User denied the request for Geolocation."; break;
                            case error.POSITION_UNAVAILABLE: errorMsg = "Location information is unavailable."; break;
                            case error.TIMEOUT: errorMsg = "The request to get user location timed out."; break;
                            case error.UNKNOWN_ERROR: errorMsg = "An unknown error occurred."; break;
                        }
                        reject(errorMsg);
                    },
                    {
                        enableHighAccuracy: true,
                        timeout: 10000,
                        maximumAge: 0
                    }
                );
            }
        });
    },
    requestNotificationPermission: async function () {
        return await Notification.requestPermission();
    },
    showNotification: function (title, options) {
        if (Notification.permission === 'granted') {
            try {
                // Try Service Worker registration first (Standard for PWA)
                navigator.serviceWorker.ready.then(function(registration) {
                    registration.showNotification(title, options);
                });
            } catch (e) {
                console.warn("ServiceWorker notification failed, falling back to new Notification()", e);
                new Notification(title, options);
            }
        } else {
            console.log("Notification permission not granted");
        }
    },
    getNotificationPermissionStatus: function () {
        return Notification.permission;
    },
    
    // Map functions
    map: null,
    marker: null,

    initializeMap: function (elementId, lat, lon) {
        if (this.map) {
            this.map.remove(); // Clean up existing map if re-initializing
        }

        this.map = L.map(elementId).setView([lat, lon], 13);

        L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 19,
            attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
        }).addTo(this.map);

        this.marker = L.marker([lat, lon]).addTo(this.map);
    },

    updateMapPosition: function(lat, lon) {
        if (this.map && this.marker) {
            var newLatLng = new L.LatLng(lat, lon);
            this.marker.setLatLng(newLatLng);
            this.map.flyTo(newLatLng, 13);
        }
    }
};