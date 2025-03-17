import Table from '@/app/components/Table/Table';
import API_ENDPOINTS from '@/app/lib/api';

interface Book {
  id: number;
  title: string;
  author: string;
  category: string;
  copiesAvailable: number;
}

const BookPage = async () => {
  const response = await fetch(API_ENDPOINTS.books);
  const books: Book[] = await response.json();
  const headers = [
    'test',
    'author',
    'category',
    'copiesAvailable',
  ];

  return (
    <div>
      <h1>Books</h1>
      <Table data={books} headers={headers} />
    </div>
  );
};

export default BookPage;
