/* Toggles the visibility of additional buttons in Worskpace */
 
var visibleButtons = 1; // Track the number of visible buttons
var buttonIds = ['btnAppxHeader', 'btnStoreHeader', 'btnTiny11']; // IDs of additional buttons

function toggleButtons(isMore) {
    if (isMore) {
        // Show more buttons
        if (visibleButtons < 4) {
            document.getElementById(buttonIds[visibleButtons - 1]).style.display = 'block';
            visibleButtons++;
            document.getElementById('lessButton').disabled = false;
            if (visibleButtons === 4) {
                document.querySelector('.additional-buttons button:first-child').disabled = true; // Disable "More" button
            }
        }
    } else {
        // Show fewer buttons
        if (visibleButtons > 1) {
            document.getElementById(buttonIds[visibleButtons - 2]).style.display = 'none';
            visibleButtons--;
            document.querySelector('.additional-buttons button:first-child').disabled = false; // Enable "More" button
            if (visibleButtons === 1) {
                document.getElementById('lessButton').disabled = true;
            }
        }
    }
}

/* Toggle the visibility of the different containers based on which navigation menu item is clicked. Also ensure that the left-container with the stepHomeHeader 
is not hidden when switching between the navigation menu items. */
function showContainer(containerId) {
    // Hide all containers except the left-container
    var containers = document.querySelectorAll('.workspace-content .glassy-box');
    containers.forEach(function(container) {
        if (container.id !== 'stepLeftHeader') {
            container.style.display = 'none';
        }
    });

    // Show the selected container
    var selectedContainer = document.getElementById(containerId);
    if (selectedContainer) {
        selectedContainer.style.display = 'block';
        
        // Trigger searchFeatures() function if system header is selected
        if (containerId === 'stepSystemHeader') {
            searchFeatures();
        }
    }
}

/* 
UI Button handling
*/

// Handle downloader
 function handleTiny11maker() {
    window.chrome.webview.postMessage('tiny11maker');
}
	
// Switch Theming
 function handleUIMode() {
    window.chrome.webview.postMessage('toggleDarkLightMode');
}
		
// Go back
function handleBackClick() {
    window.chrome.webview.postMessage('goBack');
}

// Plugin ClippySupreme > Handle button Clippy Tips
function plugClippySupreme() {
    window.chrome.webview.postMessage('plugClippySupreme');
}

// App settings button
function handleSettingsClick() {
    window.chrome.webview.postMessage('openSettings');
}

// Check for app updates button
function handleUpdatesClick() {
    window.chrome.webview.postMessage('checkAppUpdates');
}

// Refresh button
function refreshAB() {
    console.log("Refreshing Assisted buttons...");
    window.chrome.webview.postMessage('refreshAB');
}

// Assisted buttons in Clippy
function buttonClicked(index) {
    window.chrome.webview.postMessage("showAnswerForButtons:" + index.toString());
}

/* 
Log/Clippy Container
*/

// Open Clippy by clicking on clippy-container
document.addEventListener('DOMContentLoaded', function() {
    var clippyContainer = document.getElementById('clippy-container');
    clippyContainer.addEventListener('click', function() {
        window.chrome.webview.postMessage('plugClippySupreme');
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
				Question: "Ask @Copilot",
                Response: "No matches found. But hey, why not toss the challenge to Copilot? Let's see if it can lend a hand.",
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
 Plugin: CoTweaker
*/
// Handle button Search for Microsoft Copilot features in CoTweaker > AI/Copilot features in Windows section
function plugCopilotless() {
    window.chrome.webview.postMessage('plugCopilotless');
}

// This function retrieves the IDs and checked states of all checkboxes that are currently checked
function getSelectedItems() {
    var checkboxes = document.querySelectorAll('input[type="checkbox"]:checked');
    var selectedItems = [];
    checkboxes.forEach(function (checkbox) {
        selectedItems.push({ id: checkbox.id, checked: checkbox.checked });
    });

    return selectedItems;
}

// This function updates a log container with messages indicating the state (ON/OFF) of each feature based on the checked state of corresponding checkbox
function updateLog(id, isChecked) {
    var logContainer = document.getElementById('logContainer');
    var logMessage = isChecked ? `<span class="CoTweakerFeatureON">[ON]</span> ${id}` : `<span class="CoTweakerFeatureOFF">[OFF]</span> ${id}`;
    logContainer.innerHTML += logMessage + '<br>';
}

// Sends a message to backend indicating whether the feature should be enabled or disabled based on checkbox state
function updateFeatureState(checkbox) {
    var id = checkbox.id;
    var isChecked = checkbox.checked;
    updateLog(id, isChecked); // Update log if needed
    window.chrome.webview.postMessage(JSON.stringify({ action: isChecked ? 'enable' : 'disable', checkboxes: [{ id: id, checked: isChecked }] }));
}

// This function sets up event listeners for all checkboxes to call updateFeatureState when their state changes (i.e., when they are toggled)
function initializeToggles() {
    var toggles = document.querySelectorAll('input[type="checkbox"]');
    toggles.forEach(function(toggle) {
        toggle.addEventListener('change', function() {
            updateFeatureState(toggle);
        });
    });
}

document.addEventListener('DOMContentLoaded', function() {
    initializeToggles();
});

// This functions checks state of all features available in CoTweaker
function searchFeatures() {
    console.log('Detect current settings clicked');
    var selectedItems = getSelectedItems();
    window.chrome.webview.postMessage(JSON.stringify({ action: 'search', checkboxes: selectedItems }));
}

// This function toggles Descriptions on/off
function toggleDescription(label) {
    var description = label.nextElementSibling; // Get the next element, which is the description
    if (description.style.display === 'none' || description.style.display === '') {
        description.style.display = 'block';
    } else {
        description.style.display = 'none';
    }
}

/* 
 Plugin: Decrapify
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

// Remove apps listed in Assisted buttons of logContainer
function removeApp(packageName) {
   window.chrome.webview.postMessage(JSON.stringify({ action: 'removeSelectedPackages', selectedPackages: [packageName] }));
}

/* 
 Plugin: WingetUI
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
 Plugin: Extensions
*/
// Process exclusively Plugin entries from the staticAIData file 
function executePluginEntry(question) {
   window.chrome.webview.postMessage("showAnswerForPlugin:" + question);
}
// Handle plugin installation
function installPlugin(pluginName, downloadUrl) {
    window.chrome.webview.postMessage(`installPlugin:${pluginName}:${downloadUrl}`);
}
