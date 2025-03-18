'use client';

import { Field, Form } from 'react-final-form';
import API_ENDPOINTS from '@/app/lib/api';
import { useState } from 'react';

const LoginPage = () => {
  const [error, setError] = useState('');
  const [loading, setLoading] = useState(false);

  const handleLogin = async (values: { email: string; password: string }) => {
    setError('');
    setLoading(true);

    try {
      const response = await fetch(`${API_ENDPOINTS.login}`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(values),
      });

      const data = await response.json();

      let token = '';
      if (typeof data === 'string') {
        // If API returns a raw token string
        token = data;
      } else if (data.token) {
        // If API returns { token: "..." }
        token = data.token;
      }

      if (!token) {
        throw new Error('Invalid response format');
      }

      if (!response.ok) {
        throw new Error(data.message || 'Login failed');
      }

      console.log('Login successful:', token);
      localStorage.setItem('token', data.token); // Store JWT Token
    } catch (error: any) {
      console.log("hehehehe");
      setError(error.message);
    } finally {
      setLoading(false);
    }
  };

  return (
    <Form
      onSubmit={handleLogin}
      render={({ handleSubmit }) => (
        <form onSubmit={handleSubmit}>
          <div>
            <label>Email:</label>
            <Field name="email" component="input" type="email" placeholder="Email" />
          </div>

          <div>
            <label>Password:</label>
            <Field name="password" component="input" type="password" placeholder="Password" />
          </div>

          <button type="submit" disabled={loading}>
            {loading ? 'Logging in...' : 'Login'}
          </button>

          {error && <p style={{ color: 'red' }}>{error}</p>}
        </form>
      )}
    />
  );
};

export default LoginPage;
