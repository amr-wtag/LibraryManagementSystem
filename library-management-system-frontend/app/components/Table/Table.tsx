'use client';

import {useMemo, useState} from 'react';
import PropTypes from 'prop-types';
import {
  ColumnDef,
  useReactTable,
  getCoreRowModel,
  getSortedRowModel,
  getPaginationRowModel,
  flexRender,
} from '@tanstack/react-table';

interface TableProps {
  data: object[];
  headers: string[];
  textCase?: string;
}

const Table = ({data, headers, textCase = 'capitalize'}: TableProps) => {
  const columns = useMemo<ColumnDef<object>[]>(
    () =>
      headers.map((header) => ({
        id: header.toLowerCase(),
        accessorKey: header,
        header: () => <span className={textCase}>{header}</span>,
        cell: (info) => String(info.getValue() ?? 'N/A'),
      })),
    [headers, textCase]
  );

  console.log({data})

  const [pageIndex, setPageIndex] = useState(0);
  const [pageSize, setPageSize] = useState(10);

  const table = useReactTable({
    data,
    columns,
    getCoreRowModel: getCoreRowModel(),
    getSortedRowModel: getSortedRowModel(),
    getPaginationRowModel: getPaginationRowModel(),
    state: {pagination: {pageIndex, pageSize}},
    onPaginationChange: (updater) => {
      const newPagination =
        typeof updater === 'function' ? updater({pageIndex, pageSize}) : updater;
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
      <div className='flex justify-end'>
        {data.length > 10 && <div className="mt-2">
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
        </div>}
      </div>
    </div>
  );
};

Table.propTypes = {
  data: PropTypes.array.isRequired,
  headers: PropTypes.arrayOf(PropTypes.string).isRequired,
};

export default Table;
