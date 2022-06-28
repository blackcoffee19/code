//Formats response to look presentable on webpage
const renderResponse = (res) => {
    //Handles if res is falsey
    if(!res){
        console.log(res.status);
    }
    //In case res comesback as a blank array
    if(!res.length){
        responseField.innerHTML = "<p>Try again!</p><p>There were no suggestions found!</p>";
        return;
    }

    //Creates an empty array to contain the HTML strings
    let wordList = [];
    //Loops through the response and caps off at 10
    for(let i=0;i<Math.min(res.length,10);i++){
        wordList.push(`<li>${res[i].word}</li>`);
    }
    responseField.innerHTML = `<p>You might be interested in: </p><ol>${wordList}</ol>`;
    return
}
//Renders response before it is modified
const renderRawResponse = (res) => {
    //Takes the first 10 words form res
    let trimmedResponse = res.slice(0,10);
    //Manipulates responseField to render the unformatted response
    responseField.innerHTML = `<text>${JSON.stringify(trimmedResponse)}</text>`;
}

//Renders the JSON that was returned when the Promsise from fetch resolves.
const renderJsonResponse = (res) => {
    //Creates an empty object to store the JSON in key-value pairs
    let rawJson ={};
    for(let key in res){
        rawJson[key] = res[key];
    }
    //Converts JSON into a string adding line breaks to make it easier to read
    rawJson = JSON .stringify(rawJson).replace(/,/g, " \n");
    //Manipulates responseField to show the returned JSON.
    responseField.innerHTML = `<pre>${rawJson}</pre>`; 
}