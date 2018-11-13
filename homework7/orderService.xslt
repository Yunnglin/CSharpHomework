<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/">
		<html>
			<head>
				<title>Orders</title>
			</head>
			<body>
				<ul>
					<xsl:for-each select="OrderService/Orders/Order">
						<br/>
						<br/>
						<li>订单号：
							<xsl:value-of select="OrderNum" />
						</li>
						<li>客户名：
							<xsl:value-of select="ClientName" />
						</li>
						<li>手机号：
							<xsl:value-of select="PhoneNum" />
						</li>
						
						<xsl:for-each select="OrderDetails/OrderDetail">
						<li>--------
						<ul>
						<li>品牌:
							<xsl:value-of select="Brand" />
						</li>
						<li>数量:
							<xsl:value-of select="ProductsNum" />
						</li>
						<li>单价:
							<xsl:value-of select="Price" />
						</li>
						</ul>
						</li>
						</xsl:for-each>
					</xsl:for-each>
				</ul>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>