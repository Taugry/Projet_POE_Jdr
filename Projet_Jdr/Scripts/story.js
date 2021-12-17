document.addEventListener("DOMContentLoaded", function () {
    let storyContainer = document.querySelector("#story")
    let choixContainer = document.querySelector(".choix")
    var state = 0;
    var save;

    fetch('../Files/histoire.json')
        .then(response => response.json())
        .then(function (json) {
            story(json, state)
        })

    function story(json, nbr) {
        storyContainer.innerHTML = ''
        choixContainer.innerHTML = ''
        let scene = json.scenes[nbr][0]
        if (scene.hasOwnProperty('descriptions')) {
            var desc = scene.descriptions
        }
        if (scene.hasOwnProperty('analyses')) {
            var anly = scene.analyses
        }
        if (scene.hasOwnProperty('choix')) {
            var choix = scene.choix
        }
        if (scene.hasOwnProperty('missions')) {
            var missi = scene.missions
        }
            
        if (nbr == 0) {
            save = nbr;
            storyContainer.innerHTML += desc[0] + desc[1] + anly[0] + desc[2]
            choix.forEach(function (item, i) {
                choixContainer.innerHTML +=
                    `<div class="choix${i}"><input type="button" id="choix${i}" value="${i + 1}" /><label for="choix${i}">${item.description}</label></div><br />`
            })
            document.querySelectorAll('.choix input').forEach((item, i) => {
                item.onclick = function () {
                    save += "." + i;
                    choice(choix[i], json, state)
                }
            })
        } else if (nbr == 1) {
            save += ";" + nbr
            storyContainer.innerHTML = desc[0] + missi[0] + desc[1] + desc[2]
            choix.forEach(function (item, i) {
                choixContainer.innerHTML +=
                    `<div class="choix${i}"><input type="button" id="choix${i}" value="${i + 1}" /><label for="choix${i}">${item.description}</label></div><br />`
            })
            document.querySelectorAll('.choix input').forEach((item, i) => {
                item.onclick = function () {
                    save += "." + i;
                    choice(choix[i], json, state)
                }
            })
        }
        else {
            console.log(save)
            storyContainer.innerHTML = desc[0]
        }
    }

    function choice(choice, json, nbr) {
        state++
        if (choice.hasOwnProperty('reponse')) {
            storyContainer.innerHTML = choice.reponse

            choixContainer.innerHTML = `<input type="button" id="continue" value="Continuer" />`
            document.querySelector('#continue').onclick = function () {
                story(json, state)
            }
        } else {
            story(json, state)
        }
    }
});