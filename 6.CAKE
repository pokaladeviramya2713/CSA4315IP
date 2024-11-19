<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Online Cake Ordering System</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }

        h1, h2 {
            text-align: center;
        }

        form {
            width: 300px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        label {
            display: block;
            margin: 10px 0 5px;
        }

        input[type="text"],
        input[type="password"],
        input[type="email"],
        input[type="date"],
        input[type="number"],
        select {
            width: 100%;
            padding: 8px;
            margin-bottom: 10px;
            box-sizing: border-box;
        }

        input[type="submit"] {
            width: 100%;
            padding: 10px;
            background-color: #007bff;
            color: #fff;
            border: none;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background-color: #0056b3;
        }

        nav {
            text-align: center;
            margin-bottom: 20px;
        }

        nav ul {
            list-style-type: none;
            padding: 0;
        }

        nav ul li {
            display: inline;
            margin: 0 10px;
        }

        nav ul li a {
            text-decoration: none;
            color: #007bff;
        }

        nav ul li a:hover {
            text-decoration: underline;
        }

        .cake-list, .order-list {
            width: 80%;
            margin: 20px auto;
            background-color: #fff;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        .cake-item, .order-item {
            margin-bottom: 20px;
        }

        .cake-item img, .order-item img {
            width: 100%;
            height: auto;
        }

        .cake-item h3, .order-item h3 {
            margin: 10px 0 5px;
        }

        .button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #007bff;
            color: #fff;
            text-decoration: none;
            margin-top: 10px;
        }

        .button:hover {
            background-color: #0056b3;
        }
    </style>
    <script>
        document.addEventListener('DOMContentLoaded', function() {
            // Add event listeners for form submissions
            document.getElementById('registerForm')?.addEventListener('submit', function(event) {
                event.preventDefault();
                // Simulate successful registration
                alert('Registration Successful!');
                window.location.href = "#login";
            });

            document.getElementById('loginForm')?.addEventListener('submit', function(event) {
                event.preventDefault();
                // Simulate successful login
                alert('Login Successful!');
                window.location.href = "#home";
            });

            document.getElementById('orderForm')?.addEventListener('submit', function(event) {
                event.preventDefault();
                // Simulate successful order placement
                alert('Order Placed Successfully!');
                window.location.href = "#orders";
            });
        });
    </script>
</head>
<body>
    <header>
        <h1>Online Cake Ordering System</h1>
        <nav>
            <ul>
                <li><a href="#home">Home</a></li>
                <li><a href="#register">Register</a></li>
                <li><a href="#login">Login</a></li>
                <li><a href="#cakes">Browse Cakes</a></li>
                <li><a href="#orders">My Orders</a></li>
            </ul>
        </nav>
    </header>
    <main>
        <section id="home">
            <h2>Welcome to Buy a Cake</h2>
            <p>Delicious cakes delivered to your doorstep.</p>
        </section>
        <section id="register">
            <h2>User Registration</h2>
            <form id="registerForm">
                <label for="username">Username:</label>
                <input type="text" id="username" name="username" required>
                <br>
                <label for="password">Password:</label>
                <input type="password" id="password" name="password" required>
                <br>
                <label for="email">Email:</label>
                <input type="email" id="email" name="email" required>
                <br>
                <input type="submit" value="Register">
            </form>
        </section>
        <section id="login">
            <h2>User Login</h2>
            <form id="loginForm">
                <label for="username">Username:</label>
                <input type="text" id="username" name="username" required>
                <br>
                <label for="password">Password:</label>
                <input type="password" id="password" name="password" required>
                <br>
                <input type="submit" value="Login">
            </form>
        </section>
        <section id="cakes">
            <h2>Browse Cakes</h2>
            <div class="cake-list">
                <div class="cake-item">
                    <img src="images/cake1.jpg" alt="Cake 1">
                    <h3>Chocolate Cake</h3>
                    <p>Delicious chocolate cake for all occasions.</p>
                    <button onclick="window.location.href='#order'">Order Now</button>
                </div>
                <div class="cake-item">
                    <img src="images/cake2.jpg" alt="Cake 2">
                    <h3>Vanilla Cake</h3>
                    <p>Classic vanilla cake for birthdays and celebrations.</p>
                    <button onclick="window.location.href='#order'">Order Now</button>
                </div>
                <!-- Add more cakes as needed -->
            </div>
        </section>
        <section id="order">
            <h2>Order Cake</h2>
            <form id="orderForm">
                <label for="cake">Cake:</label>
                <select id="cake" name="cake" required>
                    <option value="chocolate">Chocolate Cake</option>
                    <option value="vanilla">Vanilla Cake</option>
                    <!-- Add more cakes as needed -->
                </select>
                <br>
                <label for="size">Size:</label>
                <select id="size" name="size" required>
                    <option value="small">Small</option>
                    <option value="medium">Medium</option>
                    <option value="large">Large</option>
                </select>
                <br>
                <label for="message">Message on Cake:</label>
                <input type="text" id="message" name="message">
                <br>
                <label for="delivery">Delivery Address:</label>
                <input type="text" id="delivery" name="delivery" required>
                <br>
                <label for="payment">Payment Method:</label>
                <select id="payment" name="payment" required>
                    <option value="online">Online</option>
                    <option value="offline">Offline</option>
                </select>
                <br>
                <input type="submit" value="Place Order">
            </form>
        </section>
        <section id="orders">
            <h2>My Orders</h2>
            <div class="order-list">
                <div class="order-item">
                    <h3>Order #12345</h3>
                    <p>Chocolate Cake - Medium</p>
                    <p>Delivery Address: 123 Street, City</p>
                    <p>Status: Delivered</p>
                </div>
                <div class="order-item">
                    <h3>Order #12346</h3>
                    <p>Vanilla Cake - Large</p>
                    <p>Delivery Address: 456 Avenue, City</p>
                    <p>Status: In Transit</p>
                </div>
                <!-- Add more orders as needed -->
            </div>
        </section>
    </main>
    <footer>
        <p>&copy; 2024 Buy a Cake. All rights reserved.</p>
    </footer>
</body>
</html>
