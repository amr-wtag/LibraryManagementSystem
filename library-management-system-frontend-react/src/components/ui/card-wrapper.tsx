import type { FC, ReactNode } from 'react';

import { Card, CardContent, CardDescription, CardHeader, CardTitle } from '@/components/ui/card';

interface CardWrapperProps {
  header: string;
  description?: string;
  children: ReactNode;
}

const CardWrapper: FC<CardWrapperProps> = ({ header, description, children }) => {
  return (
    <Card>
      <CardHeader>
        <CardTitle>{header}</CardTitle>
        <CardDescription>{description}</CardDescription>
      </CardHeader>
      <CardContent>{children}</CardContent>
    </Card>
  );
};

export default CardWrapper;
