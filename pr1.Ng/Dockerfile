FROM node:18.20.2 as build-env

WORKDIR /app

COPY . .
RUN npm install
RUN npm run build

FROM nginx:alpine
COPY --from=build-env /app/dist/pr1/browser /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf

