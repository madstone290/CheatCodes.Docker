#!/bin/sh
export API_PORT
export WEB_PORT

envsubst '${API_PORT} ${WEB_PORT}' < /etc/nginx/nginx.conf.template > /etc/nginx/nginx.conf

exec "$@"