'use client';

import { useMemo, useState } from 'react';
import {
  ColumnDef,
  useReactTable,
  getCoreRowModel,
  getSortedRowModel,
  getPaginationRowModel,
  flexRender,
} from '@tanstack/react-table';

interface TableProps {
  data: any[][]; // Now expects an array of arrays
  headers: string[]; // Headers are required to determine column count
  textCase?: string;
}

const Table = ({ data, headers, textCase = 'capitalize' }: TableProps) => {
  const columns = useMemo<ColumnDef<any>[]>(
    () =>
      headers.map((header, index) => ({
        id: `col-${index}`, // Unique ID based on index
        accessorFn: (row) => row[index] ?? 'N/A', // Match value by index, not key
        header: () => <span className={textCase}>{header}</span>,
        cell: (info) => String(info.getValue() ?? 'N/A'),
      })),
    [headers, textCase],
  );

  console.log('Columns:', columns.map((col) => col.id));

  const [pageIndex, setPageIndex] = useState(0);
  const [pageSize, setPageSize] = useState(10);

  const table = useReactTable({
    data,
    columns,
    getCoreRowModel: getCoreRowModel(),
    getSortedRowModel: getSortedRowModel(),
    getPaginationRowModel: getPaginationRowModel(),
    state: { pagination: { pageIndex, pageSize } },
    onPaginationChange: (updater) => {
      const newPagination =
        typeof updater === 'function' ? updater({ pageIndex, pageSize }) : updater;
      setPageIndex(newPagination.pageIndex);
      setPageSize(newPagination.pageSize);
    },
  });

  return (
    <div>
      <table className="min-w-full border border-gray-300">
        <thead>
        {table.getHeaderGroups().map((headerGroup) => (
          <tr key={headerGroup.id} className="bg-gray-200">
            {headerGroup.headers.map((header) => (
              <th key={header.id} className="p-2 border cursor-pointer">
                {flexRender(header.column.columnDef.header, header.getContext())}
              </th>
            ))}
          </tr>
        ))}
        </thead>
        <tbody>
        {table.getRowModel().rows.map((row) => (
          <tr key={row.id} className="hover:bg-gray-100">
            {row.getVisibleCells().map((cell) => (
              <td key={cell.id} className="p-2 border">
                {flexRender(cell.column.columnDef.cell, cell.getContext())}
              </td>
            ))}
          </tr>
        ))}
        </tbody>
      </table>
      <div className="flex justify-end">
        {data.length > pageSize && (
          <div className="mt-2">
            <button
              onClick={() => table.previousPage()}
              disabled={!table.getCanPreviousPage()}
              className="px-2 py-1 border"
            >
              Previous
            </button>
            <button
              onClick={() => table.nextPage()}
              disabled={!table.getCanNextPage()}
              className="ml-2 px-2 py-1 border"
            >
              Next
            </button>
          </div>
        )}
      </div>
    </div>
  );
};

export default Table;
