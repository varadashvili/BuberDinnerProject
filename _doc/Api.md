# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

### Register Request

```json
{
    "firstName": "John",
    "lastName": "Doe",
    "email": "john@johndoe.com",
    "password": "Johnd112344!"
}
```

### Register Response

```js
200 OK
```

```json
{
    "id": "cd5ba889-d6ea-48d6-9665-b6652d9539cc",
    "firstName": "John",
    "lastName": "Doe",
    "email": "john@johndoe.com",
    "token": ""
}
```

### Login

```js
POST {{host}}/auth/login
```

### Login Request

```json
{
    "email": "john@johndoe.com",
    "password": "Johnd112344!"
}
```

### Login Response

```js
200 OK
```

```json
{
    "id": "cd5ba889-d6ea-48d6-9665-b6652d9539cc",
    "firstName": "John",
    "lastName": "Doe",
    "email": "john@johndoe.com",
    "token": ""
}
```