﻿dataLayer.push({ ecommerce: null }); // Clear the previous ecommerce object.
dataLayer.push({
    event: "purchase",
    ecommerce: {
        transaction_id: "T_12345",
        affiliation: "Google Merchandise Store",
        value: 15.98,
        tax: 2.77,
        shipping: 5.99,
        currency: "EUR",
        coupon: "SUMMER_SALE",
        shipping_tier: "PostNL",
        payment_type: "Credit Card",
        customer_mail: “John@doe.com”,
        customer_phone: “0031612345678”,
        customer_first_name: “John”,
        customer_last_name: “Doe”,
        customer_adress: “Prins Bernhardlaan 59”,
        customer_city: “Borne”,
        customer_region: “Overijssel”,
        customer_postal_code: “7622BE”,
        customer_country: “NL”,
    items: [{
        item_id: "SKU_12345",
        item_name: "Stan and Friends Tee",
        affiliation: "Google Merchandise Store",
        coupon: "SUMMER_FUN",
        currency: "EUR",
        discount: 2.22,
        index: 0,
        item_brand: "Google",
        item_category: "Apparel",
        item_category2: "Adult",
        item_category3: "Shirts",
        item_category4: "Crew",
        item_category5: "Short sleeve",
        item_list_id: "related_products",
        item_list_name: "Related Products",
        item_variant: "green",
        location_id: "L_12345",
        price: 9.99,
        quantity: 1
    }]}});