module.exports = {
    root: true,
    env: { browser: true, es2021: true, node: true },
    extends: [
        'eslint:recommended',
        'plugin:react/recommended',
        'plugin:react/jsx-runtime',
        'plugin:react-hooks/recommended',
        'plugin:prettier/recommended',
    ],
    ignorePatterns: ['dist', '.eslintrc.cjs'],
    parserOptions: {
        ecmaFeatures: {
            jsx: true,
        },
        ecmaVersion: 'latest',
        sourceType: 'module',
    },
    settings: { react: { version: 'detect' } },
    plugins: ['react-refresh', 'import'],
    globals: {
        describe: true,
        test: true,
        expect: true,
        vi: true,
        beforeEach: true,
        afterEach: true,
        t: true,
    },
    rules: {
        'react/jsx-no-target-blank': 'off',
        'react-refresh/only-export-components': ['warn', { allowConstantExport: true }],
        'no-unused-vars': ['error', { varsIgnorePattern: 'React' }],
        'no-console': 'error',
        'import/order': [
            'error',
            {
                groups: ['builtin', 'external', 'internal', ['parent', 'sibling', 'index']],
                alphabetize: { order: 'asc', caseInsensitive: true },
                pathGroups: [
                    {
                        pattern: 'react',
                        group: 'builtin',
                        position: 'before',
                    },
                ],
                pathGroupsExcludedImportTypes: ['react'],
            },
        ],
        'prettier/prettier': ['error'],
        'import/no-duplicates': 'error',
    },
    overrides: [
        {
            files: ['**/*.test.js', '**/*.test.jsx'],
            rules: {
                'react/prop-types': 'off',
            },
        },
    ],
};