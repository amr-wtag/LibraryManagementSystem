import type { NextConfig } from "next";

const nextConfig: NextConfig = {
    async redirects() {
        return [
            {
                source: '/',
                destination: '/books',
                permanent: false,
            },
        ];
    },
};

export default nextConfig;
