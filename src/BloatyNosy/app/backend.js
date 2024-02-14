// Refresh Button
function refreshWebView() {
    console.log("Refreshing WebView...");
    window.chrome.webview.postMessage('refreshWebView2');
}

// Microsoft Copilot Button
function openCopilot() {
    window.chrome.webview.postMessage('openCopilot');
}

// Assisted buttons
function buttonClicked(index) {
    window.chrome.webview.postMessage("showAnswerForButtons:" + index.toString());
}

// Handle scrolling to bottom
function scrollToBottom() {
    var logContainer = document.getElementById('logContainer');
    logContainer.scrollTop = logContainer.scrollHeight;
}

// Handle log messages to logContainer
window.addEventListener('DOMContentLoaded', () => {
    window.chrome.webview.addEventListener('message', (event) => {
        const logContainer = document.getElementById('logContainer');
        logContainer.innerHTML += event.data;
    });
});

// Hide logContainer when a click occurs
document.addEventListener("click", function (event) {
    var logContainer = document.getElementById("logContainer");

    // Check if clicked element is outside logContainer
    if (!logContainer.contains(event.target)) {
        // Hide logContainer
        logContainer.style.display = "none";
    }
});

/* 
Assisted Chatbox 
*/
function chatbox(input, array) {
    var currentFocus;
    var container;

    input.addEventListener("input", function (e) {
        var val = this.value;
        closeAllLists();
        if (!val) return;
        currentFocus = -1;

        container = document.createElement("div");
        container.setAttribute("id", this.id + "chatbox-list");
        container.setAttribute("class", "chatbox-items");

        this.parentNode.appendChild(container);

        var matches = array.filter(function (item) {
            return item.toLowerCase().includes(val.toLowerCase());
        });

     // No matches found, suggest opening Copilot
		if (matches.length === 0) {
            var copilotSuggestion = {
                Question: "Ask Copilot",
                Response: "No matches found. Why not try asking Copilot?",
                Action: "openCopilot" 
            };

            displaySuggestion(copilotSuggestion);
            return;
        }
		
		// Search for matches
		for (var i = 0; i < matches.length; i++) {
			var option = document.createElement("div");
			var matchIndex = matches[i].toLowerCase().indexOf(val.toLowerCase());
			
			option.innerHTML = matches[i].substr(0, matchIndex);
			option.innerHTML += "<strong style='color: magenta; font-weight: bold;'>" + matches[i].substr(matchIndex, val.length) + "</strong>";
			option.innerHTML += matches[i].substr(matchIndex + val.length);
			option.innerHTML += "<input type='hidden' value='" + matches[i] + "'>";

			option.addEventListener("click", function (e) {
				input.value = this.getElementsByTagName("input")[0].value;
				// closeAllLists(); // Dont close results list when hitting on a result

				// Trigger action only when an item is clicked
				chatboxInputChanged();
			});
			container.appendChild(option);
		}
    });

    // Display Copilot suggestion (if not matches found!)
    function displaySuggestion(suggestion) {
        closeAllLists();

        container = document.createElement("div");
        container.setAttribute("id", input.id + "chatbox-list");
        container.setAttribute("class", "chatbox-items");

        var option = document.createElement("div");
        option.innerHTML = "<strong style='color: magenta; font-weight: bold;'>" + suggestion.Question + "</strong>";
        option.innerHTML += "<br>" + suggestion.Response;
        option.addEventListener("click", function (e) {
            input.value = suggestion.Question;
            closeAllLists();
            chatboxInputChanged();
        });
        container.appendChild(option);

        input.parentNode.appendChild(container);
    }
	
	
    // Related to styling and behavior of Chatbox list
    function addActive(x) {
        removeActive(x);
        currentFocus = (currentFocus + x.length) % x.length;
        x[currentFocus].classList.add("chatbox-active");
    }

    function removeActive(x) {
        x.forEach(item => item.classList.remove("chatbox-active"));
    }

    function closeAllLists(elmnt) {
        document.querySelectorAll(".chatbox-items")
            .forEach(item => (elmnt !== item && input !== item) && item.parentNode.removeChild(item));
    }

    // Clear the text inside the textbox when clicked
    input.addEventListener("click", function (e) {
        if (this.value !== "") {
            this.value = "";
            closeAllLists();
        }
    });
}

    // Send both question and action in the message
function chatboxInputChanged() {
    var inputValue = document.getElementById('chatbox').value;
    console.log("Chatbox item clicked:", inputValue);

    window.chrome.webview.postMessage("showAnswerForChatbox:" + inputValue);
}


/* 
Interop code > Checkboxes and Buttons 
for other dashboards, like Privacy etc.
*/
function getSelectedItems() {
    var checkboxes = document.querySelectorAll('input[type="checkbox"]:checked');
    var selectedItems = [];
    checkboxes.forEach(function (checkbox) {
        selectedItems.push({ id: checkbox.id, checked: checkbox.checked });
    });

    return selectedItems;
}

function updateLog(id, isChecked) {
    var logContainer = document.getElementById('logContainer');
    var logMessage = isChecked ? `Feature ID '${id}' is enabled.` : `Feature ID '${id}' is disabled.`;
    logContainer.innerHTML += logMessage + '<br>';
}

function searchFeatures() {
    console.log('Search Features clicked');
    var selectedItems = getSelectedItems();
    window.chrome.webview.postMessage(JSON.stringify({ action: 'search', checkboxes: selectedItems }));
}

function enableFeatures() {
    console.log('Enable Features clicked');
    var selectedItems = getSelectedItems();
    if (selectedItems.length > 0) {
        window.chrome.webview.postMessage(JSON.stringify({ action: 'enable', checkboxes: selectedItems }));
    }
}

function disableFeatures() {
    console.log('Disable Features clicked');
    var selectedItems = getSelectedItems();
    if (selectedItems.length > 0) {
        window.chrome.webview.postMessage(JSON.stringify({ action: 'disable', checkboxes: selectedItems }));
    }
}

function openUpdateSettings() {
    window.chrome.webview.postMessage('openUpdateSettings');
}

function openWallpaperSettings() {
    window.chrome.webview.postMessage('openWallpaperSettings');
}

function openThemeSettings() {
    window.chrome.webview.postMessage('openThemeSettings');
}

function checkEventViewerLogs() {
    window.chrome.webview.postMessage('checkEventViewer');
}

/* 
App Installer via Winget
*/
function installSelectedApps() {
    var selectedApps = [];

    // Get all toggle switches
    var toggles = document.querySelectorAll('.toggle-switch-checkbox');

    // Iterate through toggle switches
    toggles.forEach(function (toggle) {
        var appId = toggle.id.replace('Toggle', ''); // Extract appId from toggle ID
        var wingetIdElement = document.getElementById(appId + 'WingetId');

        if (wingetIdElement) {
            var wingetId = wingetIdElement.innerText;

            selectedApps.push({
                id: appId,
                checked: toggle.checked,
                wingetId: wingetId
            });
        } else {
            console.log(`Error: Winget ID element not found for ${toggle.id}`);
        }
    });

    // Log selected apps to console for debugging
    console.log('Selected Apps:', selectedApps);

    // Send selected apps to WebView2
    var message = JSON.stringify({
        action: 'installSelectedApps',
        checkboxes: selectedApps // No need to wrap in an additional object
    });

    console.log('Sending message:', message);
    window.chrome.webview.postMessage(message);
}


/* 
Appx Uninstaller (Crapware)
*/
// Declare selectedPackages in the global scope
var selectedPackages = selectedPackages || [];

function updateSelectedPackages(packageFamilyName) {
    // Make sure selectedPackages is an array before using indexOf
    selectedPackages = selectedPackages || [];

    var index = selectedPackages.indexOf(packageFamilyName);
    if (index === -1) {
        selectedPackages.push(packageFamilyName);
    } else {
        selectedPackages.splice(index, 1);
    }
}

function removeSelectedPackages() {
    console.log("Removing selected packages...");
    console.log(selectedPackages);
    window.chrome.webview.postMessage(JSON.stringify({ action: 'removeSelectedPackages', selectedPackages: selectedPackages }));
}

function searchCustomCrapware() {
    console.log("Searching for custom crapware...");
    window.chrome.webview.postMessage('searchCustomCrapware');
}

function removeCustomCrapware() {
    console.log("Removing custom crapware...");
    window.chrome.webview.postMessage('removeCustomCrapware');
}
