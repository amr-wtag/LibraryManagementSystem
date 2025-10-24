import { useQuery } from '@tanstack/react-query';

import { API_ROUTES } from '@/query/routes';
import axiosInstance from '@/utils/api/axios-instance';

const useGetMe = () =>
  useQuery({
    queryKey: ['me'],
    queryFn: async () => {
      const response = await axiosInstance.get(API_ROUTES.me());

      return response.data;
    },
    retry: false,
  });

export default useGetMe;
