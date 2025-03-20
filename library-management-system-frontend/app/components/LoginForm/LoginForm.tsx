import { Field } from 'react-final-form';

interface LoginFormProps {
  handleSubmit: () => {};
  error: string;
  loading: boolean;
}


const LoginForm = ({ handleSubmit, error, loading }: LoginFormProps) => {
  return (
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
  );
};

export default LoginForm;