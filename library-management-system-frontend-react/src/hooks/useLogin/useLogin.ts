/* import { useMutation } from '@tanstack/react-query';

import { API_ROUTES } from '@/query/routes';
import axiosInstance from '@/utils/api/axios-instance';

export type LoginPayload = {
  identifier: string;
  password: string;
};

export type LoginResponse = {
  token: string;
  user: {
    id: string;
    name: string;
    email: string;
  };
};

export const useLogin = () => {
  return useMutation<LoginResponse, any, LoginPayload>({
    mutationFn: async (data: LoginPayload) => {
      const response = await axiosInstance.post(API_ROUTES.login(), data);

      return response.data;
    },
  });
};
 */

import { useMutation, useQueryClient } from '@tanstack/react-query';

import { API_ROUTES } from '@/query/routes';
import axiosInstance from '@/utils/api/axios-instance';

// You MUST get this query key from your `useGetMe.ts` hook file
// It's probably defined there. Let's assume this for now:
export const GET_ME_QUERY_KEY = ['getMe'];

export type LoginPayload = {
  identifier: string;
  password: string;
};

export type LoginResponse = {
  // We may not even need the token or user back
  // if the cookie is just set. But we'll leave this.
  token: string;
  user: {
    id: string;
    name: string;
    email: string;
  };
};

export const useLogin = () => {
  const queryClient = useQueryClient(); // Get the query client

  return useMutation<LoginResponse, any, LoginPayload>({
    mutationFn: async (data: LoginPayload) => {
      const response = await axiosInstance.post(API_ROUTES.login(), data);

      return response.data;
    },

    onSuccess: async () => {
      queryClient.invalidateQueries({ queryKey: ['me'] });
    },

    onError: (error) => {
      console.error('Login failed:', error);
    },
  });
};
