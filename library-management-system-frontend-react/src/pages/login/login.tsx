import { useForm } from 'react-hook-form';
import { useNavigate } from 'react-router-dom';

import { Button } from '@/components/ui/button';
import {
  Card,
  CardContent,
  CardDescription,
  CardFooter,
  CardHeader,
  CardTitle,
} from '@/components/ui/card';
import { Input } from '@/components/ui/input';
import { Label } from '@/components/ui/label';
import { type LoginPayload, useLogin } from '@/hooks/useLogin/useLogin.ts';

type LoginFormValues = {
  identifier: string;
  password: string;
};

const Login = () => {
  const { register, handleSubmit } = useForm<LoginFormValues>();
  const navigate = useNavigate();

  const loginMutation = useLogin();

  const onSubmit = (values: LoginPayload) => {
    loginMutation.mutate(values, {
      onSuccess: (data) => {
        navigate('/dashboard');
      },
      onError: (error) => {
        console.error('Login failed:', error);
      },
    });
  };

  return (
    <Card className="w-full max-w-sm mx-auto">
      <CardHeader>
        <CardTitle>Login to your account</CardTitle>
        <CardDescription>Enter your identifier and password below to login</CardDescription>
      </CardHeader>
      <form onSubmit={handleSubmit(onSubmit)}>
        <CardContent className="space-y-4">
          <div className="grid gap-2">
            <Label htmlFor="identifier">Email</Label>
            <Input
              id="identifier"
              placeholder="Enter your email"
              {...register('identifier', { required: true })}
            />
          </div>
          <div className="grid gap-2">
            <Label htmlFor="password">Password</Label>
            <Input
              id="password"
              type="password"
              placeholder="Enter your password"
              {...register('password', { required: true })}
            />
          </div>
        </CardContent>
        <CardFooter>
          <Button type="submit" className="w-full">
            Login
          </Button>
        </CardFooter>
      </form>
    </Card>
  );
};

export default Login;
