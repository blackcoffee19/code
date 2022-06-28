//fetch() 
/*
    *Creates a request object that contains relevant information that an API needs
    *Sends that request object to the API endpoint provided
    *Returns a promise that ultimately resolves to a response object, which contains
     the status of the promise with information the API sent back
     
*/


//Use fetch() create GET resquest
/*
    Call fetch() and pass it a URL as a string for the first argument,
     determining the endpoint of the request.
    fetch("URL")+.then() is chained at the end of the fetch() function and in its 1st argument,
     the response of the GET request is passed to the callback arrow function.
     .The .then() method will fire only after the promist status of fetch() has been resoled.
    
    
     .then(response => {
        the ok property of the response object returns a Boolean value.If there are no errors, 
        response.ok will be true and the code will return response.json().
        If response.ok is falsy value, our code will throw an error.
            throw new Error('Request failed!')
    }, networkError => {
        This object logs the network Error
    })
    .then(jsonResponse =>{
        which contains the returned response.json() object from previous .then() method
        Code to execute with jsonResponse
    }) 
*/

//Infomation to reach API
const url = 'https://api.datamuse.com/words?sl=';

//Selects page elements
const inputField = document.querySelector('#input');
const submit = document.querySelector('#submit');
const responseField =document.querySelector('#responseField');

//AJAX function

const getSuggestions = () => {
    const wordQuery = inputField.value;
    const endpoint = url+wordQuery;
    fetch(
        //Sends request
        endpoint,{cache: 'no-cache'})
    .then(response =>{
        //converts response object to JSON
        if(response.ok){
            return response.json();
        };
        //Handles errors
        throw new Error('Request failed!');
    }, networkError => {
        console.log(networkError.message);
    })
    .then(jsonResponse => {
        //Handles success
        renderResponse(jsonResponse);
    });
}

const displaySuggestions = (event) => {
    event.preventDefault();
    while(responseField.firstChild){
        responseField.removeChild(responseField.firstChild);
    }
    getSuggestions();
}

submit.addEventListener('click',displaySuggestions);
/**     async await GET
 * const getData = async() => {
 *      try{
 *      const response = await fetch(API URL/endpoint);
 *      if (response.ok){
 *          const jsonResponse = await response.json();
 *          CODE TO EXECUTE WITH jsonResponse
 *       }
 *       throw new Error('Request failed!');
 *      } catch(error){
 *        console.log(error);
 *      }
 * }
 * 
 * const getSuggestions = async() => {
 *      const wordQuery = inputField.value;
 *      const endpoint = url + queryParams + wordQuery;
 *      try {
 *          const response = await fetch(endpoint, {cache: 'no-cache'})
 *          if(response.ok){
    *          const jsonResponse = await response.json();
    *          renderResponse(jsonResponse);
 *          }
 *      } catch (error){ console.log(error)}
 * }
 */