'use client';

import { Form } from 'react-final-form';
import API_ENDPOINTS from '@/app/lib/api';
import { useEffect, useState } from 'react';
import { useRouter } from 'next/navigation';
import LoginForm from '@/app/components/LoginForm/LoginForm';

const LoginPage = () => {
  const [error, setError] = useState('');
  const [loading, setLoading] = useState(false);
  const router = useRouter();
  const [isAuthChecked, setIsAuthChecked] = useState(false);
  const token = localStorage.getItem('token');
  console.log({ token });
  useEffect(() => {
    if (token) {
      router.replace('/books'); // Use replace() instead of push() to prevent back navigation
    } else {
      setIsAuthChecked(true); // Only render the form if authentication check is done
    }
  }, [router, token]);

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
      router.push('/books');

    } catch (error: any) {
      setError(error.message);
    } finally {
      setLoading(false);
    }
  };

  if (!isAuthChecked) return null;

  return (
    <Form
      onSubmit={handleLogin}
      render={({ handleSubmit }) => (
        <LoginForm handleSubmit={handleSubmit} />
      )}
    />
  );
};

export default LoginPage;
