import axios from 'axios';

const API_KEY = 'AIzaSyA_ZGanhR89HhU1Rpcvnhmskaih7GsHw7k';

export async function authenticate(action, email, password) {
    const url = `https://identitytoolkit.googleapis.com/v1/accounts:${action}?key=${API_KEY}`
    const response = await axios.post(url,
    {
        email: email,
        password: password,
        returnSecureToken: true
    });

    const token = response.data.idToken;

    return token;
}

// export async function signUp(email, password) {
//     const response = await axios.post('https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=' + API_KEY,
//         {
//             email: email,
//             password: password,
//             returnSecureToken: true
//         }
//     );
// }