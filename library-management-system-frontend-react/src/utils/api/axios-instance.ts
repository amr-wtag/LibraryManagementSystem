import axios from 'axios';

const { VITE_APP_DOMAIN } = import.meta.env;
const BASE_API_URL = `${VITE_APP_DOMAIN}/api`;

const axiosInstance = axios.create({
  baseURL: BASE_API_URL,
  withCredentials: true, // ✅ send cookies automatically
});

// --- RESPONSE INTERCEPTOR ---
// Handles responses globally
axiosInstance.interceptors.response.use(
  (response) => {
    // Successful response — just return
    return response;
  },
  async (error) => {
    const status = error?.response?.status;

    if (status === 401) {
      // Unauthorized — token invalid or expired
      console.warn('Unauthorized! Redirecting to login...');
      // Clear any user info in frontend state if you store it
      // Example: localStorage.removeItem("user"); etc.
      // window.location.href = "/"; // redirect to login page
    }

    if (status === 403) {
      // Forbidden — user role not allowed
      console.warn('Forbidden! You do not have access.');
      alert('You do not have permission to access this resource.');
    }

    // Other errors can be handled here
    return Promise.reject(error);
  }
);

export default axiosInstance;
