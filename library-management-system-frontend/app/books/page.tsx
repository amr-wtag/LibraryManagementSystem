'use client';

import { useEffect, useState } from 'react';
import Table from '@/app/components/Table/Table';
import API_ENDPOINTS from '@/app/lib/api';

interface Book {
  id: number;
  title: string;
  author: string;
  category: string;
  copiesAvailable: number;
}

const BookPage = () => {
  const [books, setBooks] = useState<Book[]>([]);


  useEffect(() => {
    const fetchBooks = async () => {
      try {
        const response = await fetch(API_ENDPOINTS.books);
        if (!response.ok) throw new Error('Failed to fetch books');
        const data: Book[] = await response.json();
        setBooks(data);
      } catch (error) {
        console.error(error);
      }
    };

    fetchBooks();
  }, []);

  const filteredBooks = books.map(({ id, ...rest }) => rest);
  const headers = ['author', 'category', 'copiesAvailable'];

  return (
    <div>
      <h1>Books</h1>
      <Table data={filteredBooks} headers={headers} />
    </div>
  );
};

export default BookPage;
