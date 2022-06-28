/*
    fetch() call take two arguments: an endpoint and an object that contains information needed for the POST request.
    the object passed to the fetch() function as its second argument contains two propertirs: method, with a value of 'POST' and boby, with a value of JSON.stringify({id: '200'})/
    The second argument determines that this request is a POST request and what information will be sent to the API.
     A successful POST request will return a response body, which will vary depending on how the API is set up.
    The rest of the request is identical to the GET request.
*/

//Information to reach API
const apiKey = 'cbc1ab6322ef4dda94993cb6a0b5b06e';
const url = 'https://api.rebrandly.com/v1/links';

//Some page elements
const inputField = document.querySelector('#input');
const shortenButton = document.querySelector('#shorten');
const responseField = document.querySelector('#responseField');

//
const shortenUrl = () => {
    const urlToShorten = inputField.value;
    //Sends request
    fetch(url,{
        method: 'POST',
        headers: {
            'Content-type': 'application/json',
            'apikey': apiKey
        },
        body: JSON.stringify({destination: urlToShorten})
    }).then(response => {
        //Converts response object to JSON
        if(response.ok){
            return response.json();
        }
        //Handles success
        throw new Error('Request failed!');
    },networkError =>{
        console.log(networkError.message);
    }).then(jsonResponse => {
        //Handles success
        renderResponse(jsonResponse);
    })
}
/** POST asynchronous functions 
 *  const shortenUrl = async() => {
 *      const urlToShorten = inputField.value;
 *      try {
 *          const response = await fetch(url,
 *             {
 *                  method: 'POST',
 *                  body: JSON.stringify({destination: urlToShorten}),
 *                  headers: {
 *                      'Content-type': 'application/json',
 *                      'apikey': apiKey
 *                  }
 *              } 
 *          );
 *          if(response.ok) {
 *              const jsonResponse = await response.json();
 *              renderResponse(jsonResponse);
 *          }
 *      } catch (error) {
 *          console.log(error);
 *      }
 * } 
 */
const displayShortUrl = (event) => {
    event.preventDefault();
    while(responseField.firstChild){
        responseField.removeChild(responseField.firstChild);
    }
    shortenUrl();
}

shortenButton.addEventListener('click',displayShortUrl);