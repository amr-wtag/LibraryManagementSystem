import Table from "@/app/components/Table/Table";

interface Book {
    id: number;
    title: string;
    author: string;
    category: string;
    copiesAvailable: number;
}

const BookPage = async () => {
    const response = await fetch('http://localhost:5049/api/book');

    const books: Book[] = await response.json();
    const headers = [
        "title",
        "author",
        "category",
        "copiesAvailable",
    ]

    console.log({response:books[0].copiesAvailable})

    return (
        <div>
            <h1>Books</h1>
            <Table data={books} headers={headers}/>
        </div>
    );
};

export default BookPage;
